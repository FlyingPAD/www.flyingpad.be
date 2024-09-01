import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditionModelsComponent } from './edition-models.component';

describe('EditionModelsComponent', () => {
  let component: EditionModelsComponent;
  let fixture: ComponentFixture<EditionModelsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditionModelsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditionModelsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
