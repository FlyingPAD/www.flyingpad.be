import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MultiTagModelsComponent } from './multi-tag-models.component';

describe('MultiTagModelsComponent', () => {
  let component: MultiTagModelsComponent;
  let fixture: ComponentFixture<MultiTagModelsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MultiTagModelsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MultiTagModelsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
