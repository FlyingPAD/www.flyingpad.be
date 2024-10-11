import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MultiTagComponent } from './multi-tag.component';

describe('MultiTagComponent', () => {
  let component: MultiTagComponent;
  let fixture: ComponentFixture<MultiTagComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MultiTagComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MultiTagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
